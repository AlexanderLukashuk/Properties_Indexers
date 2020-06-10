namespace practice
{
    public class RangeOfArray
    {
        private int _startIndex;
        private int _endIndex;
        private int _size;

        private int[] _array;
        public int this[int index]
        {
            get
            {
                if (index >= _startIndex)
                {
                    return _array[index - _startIndex];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (_startIndex > _endIndex)
                {
                    int tmp = _startIndex;
                    _startIndex = _endIndex;
                    _endIndex = tmp;
                }

                _array[index - _startIndex] = value;
            }
        }

        public int GetSize()
        {
            return _size;
        }

        public void SetSize(int size)
        {
            _size = size;
        }

        public int GetStartIndex()
        {
            return _startIndex;
        }

        public void SetStartIndex(int index)
        {
            _startIndex = index;
        }

        public int GetEndIndex()
        {
            return _endIndex;
        }

        public void SetEndIndex(int index)
        {
            _endIndex = index;
        }

        public RangeOfArray()
        {
            _size = 0;
            _array = new int[_size];
        }

        public RangeOfArray(int size)
        {
            _size = size;
            _array = new int[_size];
        }

        public RangeOfArray(int startIndex, int endIndex)
        {
            _startIndex = startIndex;
            //SetStartIndex(startIndex);
            _endIndex = endIndex + 1;
            //SetEndIndex(endIndex);
            _size = (_endIndex - 1) - _startIndex + 1;
            _array = new int[_size];
        }
    }
}