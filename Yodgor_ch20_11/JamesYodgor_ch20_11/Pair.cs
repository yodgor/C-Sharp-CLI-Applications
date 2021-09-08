namespace JamesYodgor_ch20_11
{
    public class Pair<T1, T2>
    {
        private T1 F;
        private T2 S;
        public Pair(T1 element1, T2 element2)
        {
            F = element1;
            S = element2;
        }
        public T1 getFist()
        {
            return F;
        }
        public T2 getSecond()
        {
            return S;
        }
        public void setFirst(T1 element1)
        {
            F = element1;
        }
        public void setSecond(T2 element2)
        {
            S = element2;
        }

    }
}