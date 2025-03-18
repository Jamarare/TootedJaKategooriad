using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace TootedJaKategooriad
{
    public partial class MainForm : Form
    {
        private ProductsContext? _productsContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._productsContext = new ProductsContext();
            this._productsContext.Database.EnsureCreated();
            this._productsContext.Categories.Load();
            this.categoryBindingSource.DataSource = _productsContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._productsContext?.Dispose();
            this._productsContext = null;
        }

        private void DataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this._productsContext != null)
            {
                var category = (Category)this.DataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this._productsContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }
    }
}
