import { Component } from '@angular/core';

// // Import global dependencies
// import './assets/oneui/src/assets/_es6/main/bootstrap';

// // Import required modules
// import Tools from './assets/oneui/src/assets/_es6/main/modules/tools';
// import Helpers from './assets/oneui/src/assets/_es6/main/modules/helpers';
// import Template from './assets/oneui/src/assets/_es6/main/modules/template';


@Component({
    selector: 'app-root',
    template: `<router-outlet></router-outlet>`
})
export class RootComponent {
    /*
     * Auto called when creating a new instance
     *
    //  */
    // constructor() {
    //     super();
    // }

    /*
     *  Here you can override or extend any function you want from Template class
     *  if you would like to change/extend/remove the default functionality.
     *
     *  This way it will be easier for you to update the module files if a new update
     *  is released since all your changes will be in here overriding the original ones.
     *
     *  Let's have a look at the _uiInit() function, the one that runs the first time
     *  we create an instance of Template class or App class which extends it. This function
     *  inits all vital functionality but you can change it to fit your own needs.
     *
     */

    /*
     * EXAMPLE #1 - Removing default functionality by making it empty
     *
     */

    //  _uiInit() {}


    /*
     * EXAMPLE #2 - Extending default functionality with additional code
     *
     */

    //  _uiInit() {
    //      // Call original function
    //      super._uiInit();
    //
    //      // Your extra JS code afterwards
    //  }

    /*
     * EXAMPLE #3 - Replacing default functionality by writing your own code
     *
     */

    //  _uiInit() {
    //      // Your own JS code without ever calling the original function's code
    //  }
}

// Once everything is loaded
// jQuery(() => {
//     // Create a new instance of App
//    (window as any).One = new RootComponent();
// });
