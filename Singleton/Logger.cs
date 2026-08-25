

namespace Singleton;

internal class Logger
{
    //xaricden new ile instance yaradilmasini  qarsisini alir
    //static yazilir yeni instance classin ozunundur
    private static Logger _instance;
    private Logger()
    {
    }
    //logger instance-ina erishmek ucun public static property yaradilir
    public static Logger Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }
}
