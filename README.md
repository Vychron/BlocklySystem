# BlocklySystem
My intepretation of the blockly system, made in Unity

At the time being the prototype is not yet finished, as it lacks visuals and drag-and-drop functionality, this will be added in the future.

## How it works now:

Every block has it's own script that executes it's functionality.
In the inspector, when you select a block, you can add actions or arguments to them by dragging other blocks' components in their respective lists.
A controller component is required to function as a starting point for the code execution, and as for now is triggered by pressing the spacebar.
When in play mode, you can hover your mouse over the blocks to see what code they substitute, along with all blocks set as actions or arguments of this block.

Results are printed in the console.
Problems with the block structure will be printed to the console.

## How it will work in the future:

A block can be created from the UI by dragging it from a template list.
To add a block to another one, simply drag and drop it on top of it.
To execute the code, either click on an "Execute" button or set the controller block to a listener.
To remove blocks, drag and drop them on top of the trash can icon.

Problems with the block structure will be indicated with a warning message, and the conflicting blocks will be highlighted.
