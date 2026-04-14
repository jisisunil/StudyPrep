public class Logger {
    Dictionary<string, int> logger;
    public Logger() {
        logger = new Dictionary<string, int>();
    }

    public bool ShouldPrintMessage(int timestamp, string message) {
        if(logger.TryGetValue(message, out var logtimestamp))
        {
            if(timestamp-logtimestamp<10)
            {
                return false;
            }
        }
        logger[message]= timestamp;
        

        return true;    
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp, message);
 */
