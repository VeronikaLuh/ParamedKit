import {AuthUser, AuthUserRegistration} from "@/models/AuthUser";
import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

const login = async (user: AuthUser) => {
  return await ApiService.makeApiRequest({
    url: '/api/auth/login',
    method: HttpMethods.POST,
    body: user
  });
}

const signUp = async (user: AuthUserRegistration) => {
  return await ApiService.makeApiRequest({
    url: '/api/auth/sign-up',
    method: HttpMethods.POST,
    body: user
  });
}

const authService = {
  login,
  signUp
}

export default authService;