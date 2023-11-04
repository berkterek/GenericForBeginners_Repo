
namespace GenericForBeginners
{
    public class FourthExample1<T1,T2> 
    {
        public void SetT1AndT2(T1 value1, T2 value2)
        {
            
        }

        public T1 GetT1()
        {
            T1 t1 = default;
            return t1;
        }
        
        public T2 GetT2()
        {
            T2 t2 = default;
            return t2;
        }
    }

    public class FourthExample2<T1, T2>
    where T1 : class, new()
    where T2 : new()
    {
        public void SetT1AndT2(T1 value1, T2 value2)
        {
            
        }

        public T1 GetT1()
        {
            return null;
        }
        
        public T2 GetT2()
        {
            T2 t2 = default;
            return t2;
        }
    } 
}