#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
long long int n = 1000000;
long long int thread_count;
double sum = 0;
int flag = 0;
void * Thread_sum(void* rank);
int main(int argc, char* argv[])
{
long long int thread;
pthread_t* thread_handles;
thread_count = strtol(argv[1], NULL, 10);
thread_handles = (pthread_t*)malloc(thread_count * sizeof(pthread_t));
for (thread = 0; thread < thread_count; thread++)
{
pthread_create(&thread_handles[thread], NULL, Thread_sum, (void*)thread);
}
for (thread = 0; thread < thread_count; thread++)
{
pthread_join(thread_handles[thread], NULL);
}
double pi = 4.0 * sum;
printf("Pi approximated using %llu terms is:\n", n);
printf("%.18f\n", pi);
free(thread_handles);
return 0;
}
void* Thread_sum(void* rank)
{
long long int my_rank = (long long int)rank;
double factor;
long long int i;
long long int my_n = n / thread_count;
long long int my_first_i = my_n * my_rank;
long long int my_last_i = my_first_i + my_n;
if (my_first_i % 2 == 0) factor = 1.0;
else factor = -1.0;
for (i = my_first_i; i < my_last_i; i++, factor = -factor)
{
while (flag != my_rank);
sum += factor / (2 * i + 1);
flag = (flag + 1) % thread_count;
}
return NULL;
}