import { Fundraiser } from "./../models/fundraiser";
import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:5000/api";

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const sleep = (delay: number) => {
  return new Promise((resolve) => {
    setTimeout(resolve, delay);
  });
};

axios.interceptors.response.use(async (response) => {
  try {
    await sleep(1000);
    return response;
  } catch (error) {
    console.log(error);
    return await Promise.reject(error);
  }
});

const requests = {
  get: <T>(url: string) => axios.get<T>(url).then(responseBody),
  post: <T>(url: string, body: {}) =>
    axios.post<T>(url, body).then(responseBody),
  put: <T>(url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
  del: <T>(url: string) => axios.delete<T>(url).then(responseBody),
};

const Fundraisers = {
  list: () => requests.get<Fundraiser[]>("/fundraisers"),
  details: (id: string) => requests.get<Fundraiser>(`/fundraisers/${id}`),
  create: (fundraiser: Fundraiser) =>
    requests.post<void>("/fundraisers", fundraiser),
  update: (fundraiser: Fundraiser) =>
    requests.put<void>(`/fundraisers/${fundraiser.id}`, fundraiser),
  delete: (id: string) => requests.del<void>(`/fundraisers/${id}`),
};

const agent = {
  Fundraisers,
};

export default agent;
