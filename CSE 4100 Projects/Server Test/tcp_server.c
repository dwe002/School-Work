#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <unistd.h>

void error_handling(char *message);
#define BUFFER_SIZE 1024

int main(int argc, char *argv[]) 
{
    int serv_socket;
    int clnt_socket;
    int input;

    struct sockaddr_in address;
    int opt = 1;
    int addrlen = sizeof(address);
    char buffer[BUFFER_SIZE] = {0};
    
    //Creates socket
    if ((serv_socket = socket(AF_INET, SOCK_STREAM, 0)) == 0)
    {
        perror("socket failed");
        exit(EXIT_FAILURE);
    }

    //socket to the port attatch
    if (setsockopt(serv_socket, SOL_SOCKET, SO_REUSEADDR | SO_REUSEPORT, &opt, sizeof(opt))) 
    {
        perror("setsockopt");
        exit(EXIT_FAILURE);
    }
    address.sin_family = AF_INET;
    address.sin_addr.s_addr = INADDR_ANY;
    address.sin_port = htons(atoi(argv[1]));
    
    //socket to address & port bind
    if (bind(serv_socket, (struct sockaddr *)&address, sizeof(address)) < 0) 
    {
        perror("bind failed");
        exit(EXIT_FAILURE);
    }
    
    //Listen for comm
    if (listen(serv_socket, 3) < 0) {
        perror("listen");
        exit(EXIT_FAILURE);
    }
    printf("Server listening on port %d\n", atoi(argv[1]));
    
    while (1) {
        //accept comm
        if ((clnt_socket = accept(serv_socket, (struct sockaddr *)&address, (socklen_t*)&addrlen)) < 0) {
            perror("accept");
            exit(EXIT_FAILURE);
        }

        //read input
        input = read(clnt_socket, buffer, BUFFER_SIZE);
        printf("Received message from client: %s\n", buffer);
        
        //convert to uppercase
        for (int i = 0; i < input; i++) {
            buffer[i] = toupper(buffer[i]);
        }

        //send modified input
        send(clnt_socket, buffer, strlen(buffer), 0);

        //check for termination
        if (strncmp(buffer, "QUIT", 4) == 0) {
            printf("Server is closing the connection\n");
            break;
        }

        memset(buffer, 0, BUFFER_SIZE);
    }
    
    //close socket
    close(serv_socket);
    
    return 0;
}