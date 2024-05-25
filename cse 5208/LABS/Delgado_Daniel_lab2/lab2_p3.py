from time import time, sleep
from random import randrange
import random


def random_sentence(): # generates sentence of 7 words or less
    string = '' #initiate string
    for i in range(randrange(8)): #creates condition for <=7
        with open("words.txt", "r") as text:
        
            for line in text:
                all_text = text.read()
                words = list(map(str, all_text.split()))
            
                word = (random.choice(words)) #pulls a random word from words.txt file
            string += word
            string += " "
    string = string[0:len(string)-1] #creates sentence by appending
    string += "." 
        
    return string


def write_results(sentences, times):
    print('')
    file = open("times.txt", "w") 
    print("{0:50s}{1}".format("Sentence", "Time to Complete")) #prints result to console
    for i in range(5):
        print("{0:50s}{1:.2f} seconds".format(sentences[i], times[i])) #calculates and prints average
    total_time = 0
    for i in range(5):
        total_time += times[i]
    avg = total_time / 5
    print("{0:50s}{1:.2f} seconds".format("Average:", avg)) 
    file.write("{0:50s}{1}".format("Sentence", "Time to Complete")) #writes result to file
    file.write("\n")
    for i in range(5):
        file.write("{0:50s}{1:.2f} seconds".format(sentences[i], times[i]))
        file.write("\n")
    file.write("{0:50s}{1:.2f} seconds".format("Average:", avg))
    file.close()


def main(): # generates a random sentence 5 times
    sentences = []
    times = []
    for i in range(5):
        sentences.append(random_sentence())
        start = time()
        user_in = input(sentences[i] + "\n")
        while user_in != sentences[i]:
            user_in = input(sentences[i] + "\n")
        end = time()
        times.append(end-start)
        sleep(2)
    write_results(sentences, times)  #calls write_results function

main() 