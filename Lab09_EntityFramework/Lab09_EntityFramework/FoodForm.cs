using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab09_EntityFramework.Models;

namespace Lab09_EntityFramework
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private List<Category> GetCategories()
        {
            var dbContext = new RestaurantContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();

            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Thức ăn",
                [CategoryType.Drink] = "Đồ uống"
            };

            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            var categories = GetCategories();

            foreach (var cateType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                foreach (var category in categories)
                {
                    if (category.Type != cateType.Key)
                        continue;

                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }

            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNode;
        }

        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();

            if (categoryId != null && categoryId > 0)
                foods = foods.Where(x => x.FoodCategoryId == categoryId);

            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();

            if (node == null)
                return;

            List<FoodModel> foods = null;

            if (node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }
            ShowFoodsOnListView(foods);
        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowCategories();
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null)
                return;

            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowCategories();
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0)
                return;

            var foodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0)
                return;

            var dbContext = new RestaurantContext();
            var selectedFoodId = int.Parse(lvwFood.SelectedItems[0].Text);

            var selectedFood = dbContext.Foods.Find(selectedFoodId);

            if (selectedFood != null)
            {
                dbContext.Foods.Remove(selectedFood);
                dbContext.SaveChanges();

                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchFood.Focused)
                return;

            string keyword = txtSearchFood.Text.Trim();
            var node = tvwCategory.SelectedNode;

            List<FoodModel> foods = null;

            if (node == null)
                return;

            if (node.Level == 1)
            {
                var cateType = (CategoryType)node.Tag;
                foods = SearchFoodsByName(keyword, null, cateType);
            }
            else if (node.Level == 2)
            {
                var category = node.Tag as Category;
                foods = SearchFoodsByName(keyword, category?.Id);
            }
            else
                foods = SearchFoodsByName(keyword);

            lvwFood.Items.Clear();
            ShowFoodsOnListView(foods);
        }

        private void txtSearchFood_Enter(object sender, EventArgs e)
        {
            if (txtSearchFood.Text == "Tìm kiếm theo tên món ăn...")
            {
                txtSearchFood.Text = "";
                txtSearchFood.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearchFood_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchFood.Text))
            {
                txtSearchFood.Text = "Tìm kiếm theo tên món ăn...";
                txtSearchFood.ForeColor = System.Drawing.Color.Gray;
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }

        private List<FoodModel> SearchFoodsByName(string keyword, int? categoryId = null, CategoryType? cateType = null)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();

            if (categoryId != null && categoryId > 0)
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            else if (cateType != null)
                foods = foods.Where(x => x.Category.Type == cateType);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                foods = foods.Where(x =>
                    x.Name.ToLower().Contains(keyword) ||
                    (x.Notes != null && x.Notes.ToLower().Contains(keyword))
                );
            }

            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }
    }
}
