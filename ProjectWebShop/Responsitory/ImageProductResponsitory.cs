using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory
{
    public class ImageProductResponsitory : Responsitory<ImageProducts>, IImageProductResponsitory
    {
        private DbSet<ImageProducts> imgproductEntity;
        public ImageProductResponsitory(MyDBContext context) : base(context)
        {
            imgproductEntity = context.Set<ImageProducts>();
        }
        public void DeleteImg(int id)
        {
            var img = GetImgById(id);
            imgproductEntity.Remove(img);
            context.SaveChanges();
        }

        public IEnumerable<ImageProducts> GetAllImage()
        {
            return context.ImageProducts.ToList();
        }

        public dynamic GetImgByPr(int id)
        {
            var ab = context.ImageProducts
                .Join(context.Products, a => a.prid, b => b.prid, (a, b) => new { a }).Where(p => p.a.prid == id);
            return ab.ToList();
        }

        public ImageProducts GetImgById(int id)
        {
            return context.ImageProducts
                .Where(p => p.imgid == id)
                .FirstOrDefault();
        }

        public void SaveImg(ImageProducts img)
        {
            context.Entry(img).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateImg(ImageProducts img)
        {
            context.Update(img);
            context.SaveChanges();
        }

        public ImageProducts GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ImageProducts> GetAllImgByPrid(int id)
        {
            return context.ImageProducts
                .Where(p => p.prid == id).ToList();
        }

        public void DeleteImgByPr(int id)
        {
            var list = GetImgByPr(id);
            foreach(dynamic i in list)
            {

                imgproductEntity.Remove(i);
            }
        }
    }
}
