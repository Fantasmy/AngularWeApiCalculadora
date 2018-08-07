import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'abe-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.scss']
})
export class CalculadoraComponent implements OnInit {

  public field1 :number;
  public field2 :number;
  public result :number;
  
  suma()
  {
    this.result = this.field1+this.field2
  }

  constructor() { }

  ngOnInit() {
  }

}
