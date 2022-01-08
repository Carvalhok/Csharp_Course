using System;

namespace GeneticTypes.Entity
{
    class PrintService<Generic>
    {
        private Generic[] _vector = new Generic[10];
        private int _count = 0;

        public void AddValue(Generic value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is Full");
            }

            _vector[_count] = value;
            _count++;
        }

        public Generic First()
        {
            if (_count == 0)
                throw new InvalidOperationException("PrintService is Empty");
            return _vector[0];
        }

        public void Print()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("PrintService is Empty");
            }

            Console.Write("[");
            for(int i = 0; i < _count -1; i++)
            {
                Console.Write(_vector[i] + ", ");
            }
            Console.WriteLine(_vector[_count - 1] + "] ");
        }


    }
}
