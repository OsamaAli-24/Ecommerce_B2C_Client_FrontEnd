import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, AbstractControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { Observable } from 'rxjs';
import { LoginService } from '../Services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  @Input() login?: Observable<any>;

  loginForm = this.fb.group({
    Email: ['', [Validators.required]],
    Password: ['', [Validators.required]],
  });
  constructor(private fb: FormBuilder, private loginService: LoginService) {}
  onSubmit() {
    console.warn(this.loginForm.value);
    this.getLogin(this.loginForm.value);
  }
  getLogin(params: any): void {
    //debugger;
    this.loginService
      .getLoginUser(params)
      .subscribe((data) => (this.login = data));
  }
  ngOnInit(): void {}
}
