using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.View
{
    class ViewMaterial
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Sale { get; set; }
        public string Image { get; set; }
        public string Time { get; set; }

        public ViewMaterial(DB.service_a_import service)
        {
            Image = string.IsNullOrWhiteSpace(service.ImagePath) ? @"/Услуги автосервиса\no image.png" : service.ImagePath;
            Image = service.ImagePath;
            Name = $"Название услуги:{service.Name}";
            Sale = $"Скидка:{service.Sale}";
            Price = $"Цена:{service.Price}";
            Time = $"Время выполнения:{service.Time}";

        }
    }
}
