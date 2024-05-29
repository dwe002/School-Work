from socket import *
import sys

# Sets server port and address
serverPort = 12000
address = ('localhost', serverPort)

# Create socket object, bind it to the server address and port
server = socket(AF_INET, SOCK_STREAM)
server.bind(address)
server.listen(5)

# check for incoming connection
server.listen(1)
print('The server is ready to receive.')

while True:
    # Accept new connection
    connection, addr = server.accept()
    print('Connected by', addr)

    while True:
        # Receive data from client
        data = connection.recv(1024)
        if not data:
            # If there is no data then client disconnected
            print('Client disconnected')
            break
        # Change data to uppercase
        data = data.upper()

        # Send changed data back to client
        connection.sendall(data)

        # If data is "QUIT", close connection
        if data == b'QUIT':
            connection.close()
            print('Connection closed')
            break

# Close server
server.close()