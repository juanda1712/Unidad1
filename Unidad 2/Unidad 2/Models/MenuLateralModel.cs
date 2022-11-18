using System;
using System.Collections.Generic;
using System.Text;
using Unidad_2.Views.MaestroDetalle;

namespace Unidad_2.Models
{
    internal class MenuLateralModel
    {
        public MenuLateralModel()
        {
            TargetType = typeof(MenuLateralModel);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }


    }
}
