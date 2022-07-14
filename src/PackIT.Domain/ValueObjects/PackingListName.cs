using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
    public record PackingListName
    {
        public string Value { get; }

        public PackingListName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyPackingListNameException();
            }
            Value = value;
        }
        //PackListName name'i, string değere çevir.(Conversion)
        public static implicit operator string(PackingListName name) => name.Value;
        //string name'i PackListName name değerine çevir.(Conversion)
        public static implicit operator PackingListName(string name) => new(name);
    }
}