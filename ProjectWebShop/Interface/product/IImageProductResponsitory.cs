using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System.Collections.Generic;

namespace ProjectWebShop.Interface.product
{
    public interface IImageProductResponsitory : IResponsitory<ImageProducts>
    {
        IEnumerable<ImageProducts> GetAllImage();
        IEnumerable<ImageProducts> GetAllImgByPrid(int id);
        ImageProducts GetProductById(int id);
        void SaveImg(ImageProducts img);
        void DeleteImg(int id);
        void UpdateImg(ImageProducts img);
        dynamic GetImgByPr(int id);
        void DeleteImgByPr(int id);
    }
}
