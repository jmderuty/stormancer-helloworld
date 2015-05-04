# stormancer-helloworld

A server helloworld app for Stormancer. The application declares an "hello" scene template that pushes "hello world!" to any client that connects to it on the "msg" route.

For a working javascript sample, see [this jsfiddle][http://jsfiddle.net/jmderuty/o7faet2n/]. The javascript client uses websocket as a transport. A similar native application would use UDP.

#Running it in 5 steps
1. Create a Stormancer account on http://www.stormancer.com/manage
2. Create an application (for instance helloworld)
3. Clone this repository, then push it to the repository of your newly created application. See this [article][http://www.stormancer.com/documentation/deploying-with-git] for more info.
4. Fork the [jsfiddle][http://jsfiddle.net/jmderuty/o7faet2n/] and change the configuration on line 8 to match the one for your server application (account id and application name)
5. Just look at the result window.
