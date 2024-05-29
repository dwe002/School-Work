import sys

# import socket programming library
import socket

# import thread module
import _thread
import threading

# thread function
def threaded(c):
	while True:

		# data received from client
		data = c.recv(1024)
		if not data:
			print('Bye')
			break

		# reverse the given string from client
		data = data.upper()

		# send back reversed string to client
		c.send(data)

		# If data is "QUIT", close connection
		if data == b'QUIT':
			c.close()
			print('Connection closed')
			break

	# connection closed
	c.close()

if len(sys.argv) == 2:
    port = int(sys.argv[1])
    address = ('127.0.0.1', port)

    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind(address)
    print("socket binded to port", port)

    # put the socket into listening mode
    s.listen(5)
    print("socket is listening")

    # a forever loop until client wants to exit
    while True:

        # establish connection with client
        c, addr = s.accept()
        print('Connected to :', addr[0], ':', addr[1])

        # Start a new thread and return its identifier
        _thread.start_new_thread(threaded, (c,))
    s.close()
else:
    print(f'Usage: python3 {sys.argv[0]} port_number')
