import sys

# Import socket module
import socket

if len(sys.argv) == 3:
	port = int(sys.argv[2])
	host = sys.argv[1]

	s = socket.socket(socket.AF_INET,socket.SOCK_STREAM)

	# connect to server on local computer
	s.connect((host,port))

	while True:

			# Get input from user
		message = input('Input a message: ')

		# Send message to server
		s.sendall(message.encode())

		# Receive response from server
		modifiedMessage = s.recv(1024)

		# Print modified message
		print('From Server:', modifiedMessage.decode())

		# If message is "QUIT", close connection
		if message == 'QUIT':
			s.close()
			break
	# close the connection
	s.close()
else:
	print(f'Usage: python3 {sys.argv[0]} ip_address port_number')
