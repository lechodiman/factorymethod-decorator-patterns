using System;

namespace exercise1
{
    public abstract class OrderDecorator : Order
    {
        private Order _order;

        public abstract string Description { get; set; }

        protected OrderDecorator(Order order)
        {
            _order = order;
        }

        public string GetDescription()
        {
            var orderDescription = _order.GetDescription();
            var output = orderDescription + " " + Description;
            return output;
        }
    }

    public class BigComboDecorator : OrderDecorator
    {
        string _description = "Solicita agrandar combo.";
        public BigComboDecorator(Order order) : base(order) { }

        public override string Description
        {
            get => _description;
            set =>
                _description = value;
        }
    }

    public class ExtraCheeseDecorator : OrderDecorator
    {
        string _description = "Solicita extra queso.";
        public ExtraCheeseDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class ExtraMeatDecorator : OrderDecorator
    {
        string _description = "Solicita extra carne.";
        public ExtraMeatDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class NoVegetablesDecorator : OrderDecorator
    {
        string _description = "No quiere vegetales.";
        public NoVegetablesDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class BBQDecorator : OrderDecorator
    {
        string _description = "Agrega salsa BBQ.";
        public BBQDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class BitterSweetSauceDecorator : OrderDecorator
    {
        string _description = "Agrega salsa agridulce.";
        public BitterSweetSauceDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class IceCreamDecorator : OrderDecorator
    {
        string _description = "Pide un helado como postre.";
        public IceCreamDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }

    public class ApplePieDecorator : OrderDecorator
    {
        string _description = "Pide un pie de manzana como postre.";
        public ApplePieDecorator(Order order) : base(order) { }

        public override string Description { get => _description; set => _description = value; }
    }
}
