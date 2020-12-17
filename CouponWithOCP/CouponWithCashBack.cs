using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponWithCashBack : Coupon
    {
        public double discNominal;

        public CouponWithCashBack(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }
}
