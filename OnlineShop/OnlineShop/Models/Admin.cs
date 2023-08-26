namespace OnlineShop.Models
{
    public class Admin : Person
    {
        public void AddCategory(Category Category){}
        public void EditCategory(int CategoryId){}
        public void RemoveCategory(int CategoryId){}
        public List<Category> GeListCategories(){return null; }

        public void AddProduct(Product Product){}
        public void EditProduct(int ProductId){}
        public void RemoveProduct(int ProductId){}
        public List<Product> GeListProducts(){ return null; }
    }
}
