function Year8::create( %this )
{
   exec("./lesson1/main.cs");
   
   // Default to lesson 1
   Main.ActiveActivity = Lesson1;
   
   %this.reset();
}

function Year8::destroy( %this )
{
}

function Year8::reset( %this )
{
   new ScriptObject(Main.ActiveActivity);
   
   SaveScene(GameWindow.getScene());
}