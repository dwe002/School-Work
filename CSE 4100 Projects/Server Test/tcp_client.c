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

int main(int argc, char *argv[]) {
    int socket = 0, 
    int input;
    struct sockaddr_in serv_addr;
    char buffer[BUFFER_SIZE] = {0};

    //create socket
    if ((socket = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        printf("\n Socket creation error \n");
        return -1;
    }

    // Set server address and port number
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_port = htons(atoi(argv[2]));

    //convert IPv4 address to binary
    if(inet_pton(AF_INET, argv[1], &serv_addr.sin_addr)<=0) {
        printf("\nInvalid address/ Address not supported \n");
        return -1;
    }

    //connect to server
    if (connect(socket, (struct sockaddr *)&serv_addr, sizeof(serv_addr)) < 0) {
        printf("\nConnection Failed \n");
        return -1;
    }

    //read input
    while(1) {
        printf("Enter message to send to server (type QUIT to exit): ");
        fgets(buffer, BUFFER_SIZE, stdin);

        //send input to server
        send(socket, buffer, strlen(buffer), 0);

        //check termination
        if (strncmp(buffer, "QUIT", 4) == 0) {
            printf("Client is closing the connection\n");
            break;
        }

        //clear buffer
        memset(buffer, 0, BUFFER_SIZE);

        //recieve modified input
        input = read(socket, buffer, BUFFER_SIZE);
        printf("Modified message from server: %s\n", buffer);

        //clear buffer
        memset(buffer, 0, BUFFER_SIZE);
    }

    //close socket
    close(socket);

    return 0;
}