using System;

namespace exercise1
{
    public interface Order
    {
        string GetDescription();
    }

    public class OrderA : Order
    {
        public string GetDescription()
        {
            return "combo A.";
        }
    }

    public class OrderB : Order
    {
        public string GetDescription()
        {
            return "combo B.";
        }
    }

    public class OrderC : Order
    {
        public string GetDescription()
        {
            return "combo C.";
        }
    }

    public class OrderD : Order
    {
        public string GetDescription()
        {
            return "combo D.";
        }
    }

    public class OrderE : Order
    {
        public string GetDescription()
        {
            return "combo E.";
        }
    }

    public class OrderF : Order
    {
        public string GetDescription()
        {
            return "combo F.";
        }
    }
}
