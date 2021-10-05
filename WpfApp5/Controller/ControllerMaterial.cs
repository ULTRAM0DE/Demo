using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.View;

namespace WpfApp5.Controller
{
    class ControllerMaterial
    {
        internal static List<ViewMaterial> GetViews()
        {
            try
            {
                DB.TsaplinEntities6 entities3 = new DB.TsaplinEntities6();
                var view = entities3.service_a_import.ToList();
                List<View.ViewMaterial> views = new List<ViewMaterial>();
                foreach (var item in view)
                {
                    views.Add(new ViewMaterial(item));
                }
                return views;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
           
        }

        internal static bool AddService(string name, string price, string sale, string time)
        {
            DB.TsaplinEntities6 entities6 = new DB.TsaplinEntities6();
            DB.service_a_import import = new DB.service_a_import();
            try
            {
                import.Name = name;
                import.Price = Convert.ToInt32(price);
                import.Sale = Convert.ToInt32(sale);
                import.Time = Convert.ToInt32(time);
            }
            catch
            {
                throw new Exception("Ошибка1");
            }
            if(import == null)
            {
                return false;
            }
            try
            {
                DB.TsaplinEntities6 entities61 = new DB.TsaplinEntities6();
                entities61.service_a_import.Add(import);
                entities61.SaveChanges();
                return true;

            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
