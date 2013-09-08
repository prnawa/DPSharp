namespace DesignPatterns.Structural.ProxyPattern
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request() {}
    }

    public class Proxy : Subject
    {
        private RealSubject _subject;

        public override void Request()
        {
            if(_subject == null) _subject = new RealSubject();
            _subject.Request();
        }
    }
}
