
namespace GenericForBeginners
{
    public class SecondExample1
    {
        public void SetGenericMethod<T>(T type)
        {
            //Do something like convert to json data or database or send backend cloud save
        }

        public T GetGenericMethod<T>()
        {
            //get data from like json data or database or backend cloud data load
            T value = default;
            return value;
        }
    }

    public class SecondExample2<T>
    {
        public void SetGenericMethod(T type)
        {
            //Do something like convert to json data or database or send backend cloud save
        }

        public T GetGenericMethod()
        {
            //get data from like json data or database or backend cloud data load
            T value = default;
            return value;
        }
    }

    //you can only use class and concrete classes
    public class SecondExample3<T> where T : class, IBaseGenericClass, new()
    {
        public void SetGenericMethod(T type)
        {
            //Do something like convert to json data or database or send backend cloud save
        }

        public T GetGenericMethod()
        {
            //get data from like json data or database or backend cloud data load
            T value = default;
            return value;
        }
    }

    public interface IBaseGenericClass
    {
        
    }

    public class GenericClass : IBaseGenericClass
    {
        
    }
    
    public abstract class NotRight1
    {
    
    
    }
    
    public struct NotRight2
    {
    
    
    }

    public class NotRight3
    {
        
    }

    public class UseClass
    {
        public UseClass()
        {
            SecondExample3<GenericClass> class1 = new SecondExample3<GenericClass>();
            
            // SecondExample3<NotRight1> class2 = new SecondExample3<NotRight1>();
            // SecondExample3<NotRight2> class3 = new SecondExample3<NotRight2>();
            //SecondExample3<NotRight3> class4 = new SecondExample3<NotRight3>();
        }
    }
}