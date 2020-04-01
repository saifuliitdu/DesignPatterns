using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Examples
{
    /// <summary>  
    /// The 'Product' Abstract Class  
    /// </summary>  
    abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class PlatinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;
        public CardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
            this.GetCreditCard();
        }
        public int CreditLimit
        {
            get { return _creditLimit; }
        }
        public int AnnualCharge
        {
            get { return _annualCharge; }
        }
        public abstract CreditCard GetCreditCard();
    }
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class MoneyBackFactory : CardFactory
    {
        public MoneyBackFactory(int creditLimit, int annualCharge) : base(creditLimit, annualCharge)
        {
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(CreditLimit, AnnualCharge);
        }
    }
    class TitaniumFactory : CardFactory
    {

        public TitaniumFactory(int creditLimit, int annualCharge):base(creditLimit, annualCharge)
        {
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(CreditLimit, AnnualCharge);
        }
    }
    class PlatinumFactory : CardFactory
    {

        public PlatinumFactory(int creditLimit, int annualCharge) : base(creditLimit, annualCharge)
        {
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(CreditLimit, AnnualCharge);
        }
    }
}
