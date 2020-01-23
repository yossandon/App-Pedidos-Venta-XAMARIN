using Pedidos.Views;
using System;

namespace Pedidos.ViewModels
{
    public class MasterPageMenuItem
    {
        public MasterPageMenuItem()
        {
            TargetType = typeof(MasterPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
