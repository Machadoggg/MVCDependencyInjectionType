namespace MVCDependencyInjectionType
{
    public interface ITrasient { };
    public interface IScoped { };
    public interface ISingleton { };


    public class MyObject : ITrasient, IScoped, ISingleton 
    {
        public readonly int Value;

        public MyObject()
        {
                Value = new Random().Next(10000);
        }
    }
}
