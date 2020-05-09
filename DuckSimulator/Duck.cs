using System;

namespace DuckSimulator
{
    public  abstract class Duck
    {
        //Dependency injection & Composition 
        private IFlyBehaviour FlyBehaviour { get;  }
        private ISoundBehaviour SoundBehaviour { get;  }

        protected Duck(IFlyBehaviour flyBehaviour, ISoundBehaviour soundBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            SoundBehaviour = soundBehaviour;
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void MakeSound()
        {
            SoundBehaviour.MakeSound();
        }

        protected abstract void Display();
    }

    public interface ISoundBehaviour
    {
        void MakeSound();
    }

    public interface IFlyBehaviour
    {
        void Fly();
    }

    public class Quack : ISoundBehaviour
    {
        public static Quack CreateInstance()
        {
            return new Quack();
        }

        public void MakeSound()
        {
            Console.WriteLine("quack, quack!");
        }
    }
    public class Mute : ISoundBehaviour
    {
        public static Mute CreateInstance()
        {
            return new Mute();
        }

        public void MakeSound()
        {
            Console.WriteLine("silence");
        }
    }
    public class CanFly : IFlyBehaviour
    {
        public static CanFly CreateInstance()
        {
            return new CanFly();
        }

        public void Fly()
        {
            Console.WriteLine("flying away");
        }
    }
    public class CanNotFly : IFlyBehaviour
    {
        public static CanNotFly CreateInstance()
        {
            return new CanNotFly();
        }

        public void Fly()
        {
            Console.WriteLine("sorry, can't fly");
        }
    }

}
