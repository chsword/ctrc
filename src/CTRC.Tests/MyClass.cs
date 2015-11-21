namespace CTRC.Tests
{
    internal class MyClass1
    {
        public int atc = 0;
    }

    class MyClass
    {
        public void Test1() { }
        public void Test1(int i) { }
        public void Test1(int i,int j) { }
        public void Test12(int i, int j) { }
        public void Test13(int i, int j) { }
        public void Test14(int i, int j) { }
        public void Test15(int i, int j) { }
        public int _atc = 1;
        public int _atc2 = 1;
        // public int _atc3 = 1;

        public T Generic<T>(T t)
        {
            return t;
        }
    }
}