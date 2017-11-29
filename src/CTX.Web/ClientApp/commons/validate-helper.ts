export class Validation {

  static emailValidator(email: string): boolean {
    if (email === undefined) return true;
    let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
  }

  static validateRegex(data: string, reg: string): boolean {
    if (data === undefined)return false;
    let re = new RegExp(reg);
    return re.test(data);

  }

  static validateNull(data: string): boolean {
    return data ? this.validateLength(data, 1) : false;
  }

  static validateEmail(data: string): boolean {
    return data == "" || this.emailValidator(data);
  }

  static validateLength(data: string, length: number, isMaxlength: boolean = false): boolean {
    return isMaxlength ? (data + "").length <= length : (data + "").length >= length;
  }
}