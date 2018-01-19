namespace Exam5
{
    /// <summary>
    /// Customer data and logic for calculating price discounts
    /// </summary>
    class Customer
    {
        // base price (without discounts) for customer
        private const double BASEPRICE = 16;

        private string _name = null;
        private int _age = 0;
        private bool _isStudent = false;
        private bool _isConscript = false;
        private bool _isMTKmember = false;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> customer's name </param>
        public Customer(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Properties
        /// set and get
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool IsStudent
        {
            get { return _isStudent; }
            set { _isStudent = value; }
        }

        public bool IsConscript
        {
            get { return _isConscript; }
            set { _isConscript = value; }
        }

        public bool IsMTKmember
        {
            get { return _isMTKmember; }
            set { _isMTKmember = value; }
        }


        /// <summary>
        /// Calculate actual price for customer
        /// </summary>
        /// <returns> actual price with discounts </returns>
        public double GetPrice()
        {
            double price = BASEPRICE;

            if (Age < 7)
            {
                price = 0.00f; // free ticket for children under 7 years old
            }
            else if (IsMTKmember && IsStudent)
            {
                price *= 0.40f; // 15% + 45% discount if customer is both student and member of MTK
            }
            else if (Age >= 65)
            {
                price *= 0.50f; // 50% discount for pensioners
            }
            else if (Age <= 15)
            {
                price *= 0.50f; // 50% discount for young people (age between 7 and 15 (inclusive))
            }
            else if (IsConscript)
            {
                price *= 0.50f; // 50% discount for conscripts
            }
            else if (IsStudent)
            {
                price *= 0.55f; // 45% discount for students
            }
            else if (IsMTKmember)
            {
                price *= 0.85f; // 15% discount for members of MTK
            }
            else
            {
                // no discount
            }

            return price;
        }

    }
}
