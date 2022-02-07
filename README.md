# valuetask vs task



## Use Task when your code is always async
## Use ValueTask when in method hot path of code runs synchronously (most of the time executed code block) like getting data from cache while another path runs asynchronously like getting data from IO or network



Use Valuetask when method has two block conditional code where one is like IO operation and needs asynchronous code and other block doesn't need as may be data is fetched from cache (hot path of code).



In case of Task no matter your code uses synchronous or asynchronous block of code, every time Task object is create and it consume memory while as in using ValueTask only creates object when async part is executed and for other other flow directly returns value without creating task object



## But if your code is always async then use Task becasue in ValueTask async adds more information than Task so it needs more memory
