# valuetask vs task


Use Valuetask when method has two block conditional code where one is like IO opeartion and needs asynchronous code and other block doesn't need as may be data is fetched from cache (hot path of code).

In case of Task no mather your code uses synchronous or asynchronous block of code, every time Task object is create and it consume memory while as in using ValueTask only creates object when async part is executed and for other part directly returns value.

But if your code is always async then use Task
