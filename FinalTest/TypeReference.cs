namespace FinalTest
{
    public class TypeReference
    {
        protected bool Equals(TypeReference other)
        {
            return i == other.i;
        }

        public override int GetHashCode()
        {
            return i;
        }

        public int i;

        public TypeReference(int i)
        {
            this.i = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var typeRefObj = obj as TypeReference;

            return (typeRefObj.i == this.i);
        }
    }
}