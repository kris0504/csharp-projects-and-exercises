using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasierki
{
    public class Cashier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public double Supplement()
        {
            if (Experience>=24)
            {
                return Salary * 0.25;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"N:{Id};{Name};Заплата: {Salary:f2} ; Стаж: {Experience};Добавка{Supplement():f2}";
        }
    }
}
