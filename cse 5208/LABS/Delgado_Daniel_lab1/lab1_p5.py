name = input('Enter Student Name:')
nCourses = int(input('Enter number of courses?'))

i = 0
list_course = []
list_score = []
list_gpa = []

def gpa(score):
        if 93 <= score:
            gpa = 4.0
        else:
            if 90 <= score: 
                gpa = 3.7
            else:
                if 87 <= score: 
                        gpa = 3.3
                else:
                    if 83 <= score: 
                            gpa = 3.0
                    else:
                        if 80 <= score: 
                                gpa = 2.7
                        else:
                            if 77 <= score: 
                                    gpa = 2.3
                            else:
                                if 73 <= score: 
                                        gpa = 2.0
                                else:
                                    if 70 <= score: 
                                            gpa = 1.7
                                    else:
                                        if 67 <= score: 
                                                gpa = 1.3
                                        else:
                                            if 63 <= score: 
                                                    gpa = 1.0
                                            else:
                                                if 60 <= score: 
                                                        gpa = 0.7
                                                else:
                                                    if score < 60:
                                                            gpa = 0.0
                                                            
        return gpa
        
def gpaAll(list_gpa):
  return sum(list_gpa) / len(list_gpa)


while i < nCourses:
    course = input(f'Course # {i+1}', )
    list_course.append(course)
    score = int(input('Course Grade (0-100)?'))
    list_score.append(score)
    list_gpa.append(gpa(score))  
    i+=1

print()
print('Here is :', name, "'s Report card")
print('------------------------------------')
print('Course : Grade : GPA')
print('------------------------------------')
for i in range(0, nCourses):
    print(list_course[i:i+1],':',list_score[i:i+1],':',list_gpa[i:i+1])
print('Quarter GPA:', gpaAll(list_gpa))

                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        