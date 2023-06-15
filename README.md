# AWS_Sample5_1_SQS

This code is an example of how to create an Amazon Simple Queue Service (SQS) queue using the AWS SDK for .NET.

The code first sets up the necessary configurations and attributes for the queue, such as the queue name, maximum message size, delay seconds, message retention period, receive message wait time, and visibility timeout.

Then, an instance of the AmazonSQSClient class is created to interact with the SQS service.

A CreateQueueRequest object is initialized with the specified attributes and queue name.

The CreateQueueAsync method is called with the CreateQueueRequest object to asynchronously create the queue.

If the queue creation is successful, the code outputs a success message along with the URL of the created queue.

In summary, this code sets up the necessary configurations and creates an SQS queue using the AWS SDK for .NET.

This is a more detailed explanation about the code:

The code is written in C# and organized under the namespace CreateQueueExample.

It imports the necessary namespaces for working with SQS, including Amazon.SQS and Amazon.SQS.Model.

The CreateQueue class contains a static Main method, which serves as the entry point of the program.

Inside the Main method, an instance of the AmazonSQSClient class is created. This class represents the client for interacting with the SQS service.

The code specifies the queue name as "New-Example-Queue" and sets the maxMessage variable to define the maximum message size (256 KB).

A dictionary called attrs is created to store the queue attributes. The attributes include:

QueueAttributeName.DelaySeconds: Sets the delay time for messages in the queue to 5 seconds.
QueueAttributeName.MaximumMessageSize: Sets the maximum message size to the value stored in the maxMessage variable.
QueueAttributeName.MessageRetentionPeriod: Sets the message retention period to 4 days.
QueueAttributeName.ReceiveMessageWaitTimeSeconds: Sets the maximum time for long polling to 5 seconds.
QueueAttributeName.VisibilityTimeout: Sets the visibility timeout for messages in the queue to 12 hours.
A CreateQueueRequest object is created, specifying the queue attributes and name.

The CreateQueueAsync method is called on the client object, passing in the request object. This method sends a request to create the queue asynchronously and returns a CreateQueueResponse.

The response is awaited, and once received, the code checks the HttpStatusCode property of the response to determine if the queue creation was successful.

If the queue creation was successful, it outputs a success message to the console, along with the URL of the created queue.

In summary, this code creates an SQS queue with specified attributes using the AWS SDK for .NET and then displays the result of the queue creation process.

```csharp

```
