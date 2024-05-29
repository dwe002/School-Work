from socket import *
import sys

# Sets server port and address
serverPort = 12000
address = ('localhost', serverPort)

# Create socket object, connect to server
client = socket(AF_INET, SOCK_STREAM)
client.connect(address)

while True:
    # Get input from user
    message = input('Input a message: ')

    # Send message to server
    client.sendall(message.encode())

    # Receive response from server
    modifiedMessage = client.recv(1024)

    # Print modified message
    print('From Server:', modifiedMessage.decode())

    # If message is "QUIT", close connection
    if message == 'QUIT':
        client.close()
        break

# Close client
client.close()