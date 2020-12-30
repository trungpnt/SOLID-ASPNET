using System.Collections.Generic;

namespace D_Principle_VIOLATED.Models
{
    public class OrderPizza {
        private int id;
        private string time;
        private IEnumerable<Pizza> pizzas;

        public OrderPizza(int id, string time, IEnumerable<Pizza> pizzas) {
            this.id = id;
            this.time = time;
            this.pizzas = pizzas;
        }

    }
}
