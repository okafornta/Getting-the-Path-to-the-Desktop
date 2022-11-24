/* TASK: 
 * 
 *  When you work with files, you might want to create a file on the user’s desktop. However,
    everybody has their own file system path to the desktop. I will show you how to find that
    path
 */
// Finding path to the desktop
string pathToDeskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

//Output
Console.WriteLine("Way to my desktop - " + pathToDeskTop);

//Waiting for Enter
Console.ReadLine();


/* Enumeration:
 * 
 *  Pay special attention to the way you have specified that you are interested in the desktop.
    The value of Desktop is one of the values of an enumeration called Environment.Special
    Folder.
    Whenever Visual Studio wants you to enter an enumeration’s value, it usually offers
    you a corresponding enumeration. In this case, when you choose GetFolderPath from
    IntelliSense and type an open parenthesis afterward, the Environment.SpecialFolder
    enumeration immediately pops up.
 */ 