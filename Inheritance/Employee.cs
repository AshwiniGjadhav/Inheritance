using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        protected int eid;
        private static int count = 0;
        protected string name;
        protected double hra, da, pt, pf, bs, total, netpaid;
        public Employee(string name, double pt, double bs)
        {
            count++;
            eid = count;
            this.name = name;
            this.pt = pt;
            this.bs = bs;
        }

        public virtual void Calculate()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;

            total = bs + hra + da;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"\nemployee details : \nempid {eid} \nname {name} \ntotalsalary {total} \nnetpaid {netpaid}";
        }
    }
    public class Manager : Employee
    {
        private double ta;

        public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt)
        {
            this.ta = ta;
        }
        public new void Calculate()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;

            total = bs + hra + da + ta;
            netpaid = total - (pf + pt);
        }

        public override string ToString()
        {
            return $"\nmanager detail: Manager id {eid} \nname {name} \nhra {hra} \nda {da} \npf {pf} \ntotalsalary {total} \nnetPaid {netpaid}";
        }

    }
    public class SalesManager : Employee
    {
        private double bonus, comm;

        public SalesManager(string name, double bs, double pt, double bonus, double comm) : base(name, bs, pt)
        {
            this.bonus = bonus;
            this.comm = comm;
        }
        public override void Calculate()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;

            total = bs + hra + da + bonus + comm;
            netpaid = total - (pf + pt);
        }

        public override string ToString()
        {
            return $"\nSalesManager detail: Manager id {eid} \nname {name} \ntotalsalary {total} \nnetPaid {netpaid}";
        }

    }

}
