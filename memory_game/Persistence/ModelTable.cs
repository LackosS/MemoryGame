using System;

namespace memory_game.Persistence
{
    public class ModelTable
    {
        private Int32[] _fieldValues;
        private Int32 _size;
        public Int32 Size { get => _size; set => _size = value; }
        public Int32 this[Int32 x] { get { return GetValue(x); } }

        public ModelTable() : this(4) { }

        public ModelTable(Int32 tableSize)
        {
            if (tableSize < 0)
                throw new ArgumentOutOfRangeException("The table size is less than 0.", "tableSize");

            _fieldValues = new Int32[tableSize];
        }

        public Int32 GetValue(Int32 x)
        {
            if (x < 0 || x >= _fieldValues.GetLength(0))
                throw new ArgumentOutOfRangeException("x", "The X coordinate is out of range.");

            return _fieldValues[x];
        }

        public void SetValue(Int32 x, Int32 value)
        {
            if (x < 0 || x >= _fieldValues.GetLength(0))
                throw new ArgumentOutOfRangeException("x", "The X coordinate is out of range.");
            if (value < 0 || value > _fieldValues.GetLength(0) + 1)
                throw new ArgumentOutOfRangeException("value", "The value is out of range.");

            _fieldValues[x] = value;
        }
    }
}
