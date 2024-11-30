import {Rate} from "@/models/Rate";
import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

const getRates = async (restaurantId: string) => {
  return await ApiService.makeApiRequest({
    url: `/api/rate/${restaurantId}`,
    method: HttpMethods.GET,
  });
}

const addRate = async (rate: Rate) => {
  return await ApiService.makeApiRequest({
    url: "/api/rate",
    method: HttpMethods.POST,
    body: rate,
  });
}

const deleteRate = async (id: string) => {

}

export const rateService = {
  getRates,
  addRate,
  deleteRate
}