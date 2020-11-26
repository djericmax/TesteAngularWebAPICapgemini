import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TesteCapgeminiAngular';

  constructor(){}

  ngOnInit(){

  }

  onChange(event){
    const selectedFiles = <FileList>event.srcElement.files;
    document.getElementById('customfilelabel') .innerHTML = selectedFiles[0].name;
  }
}
