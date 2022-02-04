# valuetask-vs-task


Use Valuetask when method has two block conditional code where one is like IO opeartion and needs asynchronous code and other block doesn't need
In that case better to use ValueTask because In case of Task no mather your code uses synchronous or asynchronous block of code every time Task object is create and it consume memory while as in using ValueTask only creates object when async parth is executed and for other parth directly returns value.

But if your code is always async then use Task
