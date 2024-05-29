echo "Enter the directory name:"
read DIR

if [ ! -d $DIR ]
then
    mkdir $DIR
    echo "Create $DIR"
else
    echo "$DIR exists"
fi

for i in *.cpp
do 
    cmp -s $i $DIR/$i
    if [  $? -ne 0 ]
    then
        cp $i $DIR/
        echo "Backup $i"
    else
        echo "$i no update"
    fi
done