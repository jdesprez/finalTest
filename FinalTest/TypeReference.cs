namespace FinalTest
{
    public class TypeReference
    {
        public int i;

        public TypeReference(int i)
        {
            this.i = i;
        }

        public bool Equals(TypeReference obj)
        {
            return obj.i == this.i;
        }
    }
}