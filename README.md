# ActionsWithTargetsAPI
Proof of concept I threw together to demonstrate targeting multiple objects with actions.

But a single action can have multiple "child" actions, and thus multiple sets of targets.

For example: Target X, Y, Z, and do <Action1> to them, then target A, B, C and do <Action2> to them. All in one single action, <Action12>. 

This is simply a proof of concept I hacked together and not intended to be production code. There is minimal error handling and validation.
There are unit tests, but they are minimal.

Here is a sample postman call:

```
POST /api/IncrementDecrementAction HTTP/1.1
Host: localhost:62357
Content-Type: application/json
Cache-Control: no-cache
Postman-Token: f09f6861-270c-31ba-b62f-b54b2d0c8c34
```

```
{
    "incrementTargets": [
    	{
    		"id" : 1,
    		"count" : 2
    	},
    	{
    		"id" : 2,
    		"count" : 3
    	}],
    "decrementTargets": [
    	{
    		"id" : 3,
    		"count" : 10
    	}
    ]
}
```

and a response:

```
{
    "incrementTargets": [
        {
            "count": 3,
            "id": 1
        },
        {
            "count": 4,
            "id": 2
        }
    ],
    "decrementTargets": [
        {
            "count": 9,
            "id": 3
        }
    ]
}
```

One application is in a game, where one "action" or "effect" might have multiple sub actions.
