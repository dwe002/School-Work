from random import sample

def typoglycemia(paragraph): #creates typoglycemia function
    new_input="" #assigns scrambled text
    for text in paragraph.split():
        text_length=len(text)
        if text_length<3: #avoids scrambling text with 3 letters or less
            new_input+=text+" " 
        else: #scrambles text
            scramble=sample(range(1,len(text)-1),len(text)-2)
            new_input=new_input+text[0]
            for i in scramble: #replaces normal text with scrambled text
                new_input=new_input+text[i]
            new_input=new_input+text[-1]+" "
    return new_input

def main():
    fileout=open("scrambled.txt","w") #creating scrambled.txt file
    with open('example.txt') as f:      #reading from example.txt file
        for line in f:
            new_line=typoglycemia(line)     #calling function typoglycemia
            fileout.write(f"{new_line}\n")

    fileout.close()

if __name__ == '__main__':
    main()

