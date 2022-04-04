using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSM;
using OrmCs;

namespace XICSM.VanillaTools
{
    class Converter
    {
        public static bool ConvertMwToOt(IMQueryMenuNode.Context context)
        {
            YMicrowa Mwa = new YMicrowa();
            Mwa.LoadWithComponents2(context.TableId);

            if (Mwa.m_passive == 0 && Mwa.m_standard == "R")
            {
                //Define new stations equivalent to MWS A+B
                YMobStationT OTS_A = new YMobStationT();
                OTS_A.Table = "MOB_STATION"; OTS_A.AllocID();
                YMobStationT OTS_B = new YMobStationT();
                OTS_B.Table = "MOB_STATION"; OTS_B.AllocID();

                //Station A Parameters
                OTS_A.m_name = Mwa.m_StationA.m_cust_txt1;
                
                OTS_A.m_link_ident = Mwa.m_link_ident;
                OTS_A.m_status = Mwa.m_status;
                OTS_A.m_t_geo_type = "Z";
                OTS_A.m_caract = Mwa.m_cust_txt11;
                OTS_A.m_standard = Mwa.m_standard;
                OTS_A.m_cust_txt10 = Mwa.m_cust_txt6;
                OTS_A.m_type2 = Mwa.m_cust_txt11;
                OTS_A.m_cust_nbr2 = Mwa.m_cust_nbr2;
                OTS_A.m_cust_txt8 = Mwa.m_cust_txt12;
                OTS_A.m_adm = Mwa.m_adm;

                OTS_A.m_pos_id = Mwa.m_StationA.m_site_id;
                OTS_A.m_ant_id = Mwa.m_StationA.m_ant_id;
                OTS_A.m_equip_id = Mwa.m_eqpmw_id;
                OTS_A.m_lic_id = Mwa.m_lic_id;
                OTS_A.m_operator_id = Mwa.m_operator_id;
                OTS_A.m_owner_id = Mwa.m_owner_id;
                OTS_A.m_plan_id = Mwa.m_plan_id;
                OTS_A.m_impop_id = Mwa.m_impop_id;
                                
                OTS_A.m_power = Mwa.m_StationA.m_eirp;
                OTS_A.m_t_pwr_xyz = Mwa.m_pwr_xyz;
                OTS_A.m_pwr_ant = (Mwa.m_StationA.m_power == 0 ? 0 : Mwa.m_StationA.m_power - 30);
                OTS_A.m_ant_type = "I";
                OTS_A.m_tx_addlosses = Mwa.m_StationA.m_tx_addlosses;
                OTS_A.m_feeder_loss = Mwa.m_StationA.m_feeder_loss;
                OTS_A.m_rx_losses = Mwa.m_StationA.m_rx_losses;
                OTS_A.m_tx_losses = Mwa.m_StationA.m_tx_losses;
                OTS_A.m_gain = Mwa.m_StationA.m_gain;

                OTS_A.m_polar = Mwa.m_StationA.m_polar;
                OTS_A.m_desig_emission = Mwa.m_desig_em;
                OTS_A.m_class = Mwa.m_class;
                OTS_A.m_operation_mode = Mwa.m_cust_txt4;
                OTS_A.m_channel_sep = Mwa.m_channel_sep;
                OTS_A.m_bw = Mwa.m_bw;

                OTS_A.m_f10_hour = Mwa.m_f10_hour;
                OTS_A.m_op_hh_fr = Mwa.m_start_time;
                OTS_A.m_op_hh_to = Mwa.m_stop_time;

                OTS_A.m_agl = Mwa.m_StationA.m_agl1;
                OTS_A.m_agl2 = Mwa.m_StationA.m_agl2;
                OTS_A.m_azimuth = Mwa.m_StationA.m_azimuth;
                OTS_A.m_elevation = Mwa.m_StationA.m_angle_elev;
                OTS_A.m_num_anfr = Mwa.m_StationA.m_num_anfr;
                OTS_A.m_no_support = Mwa.m_StationA.m_no_support;

                OTS_A.m_biuse_date = Mwa.m_biuse_date;
                OTS_A.m_date_created = Mwa.m_date_created;
                OTS_A.m_date_modified = Mwa.m_date_modified;
                OTS_A.m_eouse_date = Mwa.m_eouse_date;
                OTS_A.m_renew_date = Mwa.m_renew_date;
                OTS_A.m_lic_auth = Mwa.m_StationA.m_lic_auth;
                OTS_A.m_created_by = Mwa.m_created_by;
                OTS_A.m_modified_by = Mwa.m_modified_by;
                OTS_A.m_remark = Mwa.m_remark;
                OTS_A.m_cust_dat1 = Mwa.m_attrib_decis_date;
                OTS_A.m_cust_dat2 = Mwa.m_modif_date;

                OTS_A.Save();

                // ----------------------------------------------- //

                //Station B Parameters
                OTS_B.m_name = Mwa.m_StationB.m_cust_txt1;

                OTS_B.m_link_ident = Mwa.m_link_ident;
                OTS_B.m_status = Mwa.m_status;
                OTS_B.m_t_geo_type = "Z";
                OTS_B.m_caract = Mwa.m_cust_txt11;
                OTS_B.m_standard = Mwa.m_standard;
                OTS_B.m_cust_txt10 = Mwa.m_cust_txt6;
                OTS_B.m_type2 = Mwa.m_cust_txt11;
                OTS_B.m_cust_nbr2 = Mwa.m_cust_nbr2;
                OTS_B.m_cust_txt8 = Mwa.m_cust_txt12;
                OTS_B.m_adm = Mwa.m_adm;

                OTS_B.m_pos_id = Mwa.m_StationB.m_site_id;
                OTS_B.m_ant_id = Mwa.m_StationB.m_ant_id;
                OTS_B.m_equip_id = Mwa.m_eqpmw_id;
                OTS_B.m_lic_id = Mwa.m_lic_id;
                OTS_B.m_operator_id = Mwa.m_operator_id;
                OTS_B.m_owner_id = Mwa.m_owner_id;
                OTS_B.m_plan_id = Mwa.m_plan_id;
                OTS_B.m_impop_id = Mwa.m_impop_id;

                OTS_B.m_power = Mwa.m_StationB.m_eirp;
                OTS_B.m_t_pwr_xyz = Mwa.m_pwr_xyz;
                OTS_B.m_pwr_ant = (Mwa.m_StationB.m_power == 0 ? 0 : Mwa.m_StationB.m_power - 30);
                OTS_B.m_ant_type = "I";
                OTS_B.m_tx_addlosses = Mwa.m_StationB.m_tx_addlosses;
                OTS_B.m_feeder_loss = Mwa.m_StationB.m_feeder_loss;
                OTS_B.m_rx_losses = Mwa.m_StationB.m_rx_losses;
                OTS_B.m_tx_losses = Mwa.m_StationB.m_tx_losses;
                OTS_B.m_gain = Mwa.m_StationB.m_gain;

                OTS_B.m_polar = Mwa.m_StationB.m_polar;
                OTS_B.m_desig_emission = Mwa.m_desig_em;
                OTS_B.m_class = Mwa.m_class;
                OTS_B.m_operation_mode = Mwa.m_cust_txt4;
                OTS_B.m_channel_sep = Mwa.m_channel_sep;
                OTS_B.m_bw = Mwa.m_bw;
                
                OTS_B.m_f10_hour = Mwa.m_f10_hour;
                OTS_B.m_op_hh_fr = Mwa.m_start_time;
                OTS_B.m_op_hh_to = Mwa.m_stop_time;

                OTS_B.m_agl = Mwa.m_StationB.m_agl1;
                OTS_B.m_agl2 = Mwa.m_StationB.m_agl2;
                OTS_B.m_azimuth = Mwa.m_StationB.m_azimuth;
                OTS_B.m_elevation = Mwa.m_StationB.m_angle_elev;
                OTS_B.m_num_anfr = Mwa.m_StationB.m_num_anfr;
                OTS_B.m_no_support = Mwa.m_StationB.m_no_support;

                OTS_B.m_biuse_date = Mwa.m_biuse_date;
                OTS_B.m_date_created = Mwa.m_date_created;
                OTS_B.m_date_modified = Mwa.m_date_modified;
                OTS_B.m_eouse_date = Mwa.m_eouse_date;
                OTS_B.m_renew_date = Mwa.m_renew_date;
                OTS_B.m_lic_auth = Mwa.m_StationB.m_lic_auth;
                OTS_B.m_created_by = Mwa.m_created_by;
                OTS_B.m_modified_by = Mwa.m_modified_by;
                OTS_B.m_remark = Mwa.m_remark;
                OTS_B.m_cust_dat1 = Mwa.m_attrib_decis_date;
                OTS_B.m_cust_dat2 = Mwa.m_modif_date;

                OTS_B.Save();

                //Frequencies regarding modex
                YMobstaFreqsT FreqA = new YMobstaFreqsT();
                FreqA.Table = "MOBSTA_FREQS";
                FreqA.m_sta_id = OTS_A.m_id;
                FreqA.AllocID();

                YMobstaFreqsT FreqB = new YMobstaFreqsT();
                FreqB.Table = "MOBSTA_FREQS";
                FreqB.m_sta_id = OTS_B.m_id;
                FreqB.AllocID();

                if (Mwa.m_cust_txt4 == "F" || Mwa.m_StationA.m_tx_freq == Mwa.m_StationB.m_tx_freq)
                {
                    FreqA.m_tx_freq = Mwa.m_StationA.m_tx_freq;
                    FreqA.m_rx_freq = Mwa.m_StationB.m_tx_freq;

                    FreqA.m_tx_rra_id = Mwa.m_StationA.m_tx_rra_id;
                    FreqA.m_tx_rrb_id = Mwa.m_StationA.m_tx_rrb_id;
                    FreqA.m_tx_rrs_id = Mwa.m_StationA.m_tx_rrs_id;
                    FreqA.m_tx_rr_diag = Mwa.m_StationA.m_tx_rr_diag;
                    FreqA.m_tx_rr_exc = Mwa.m_StationA.m_tx_rr_exc;
                    FreqA.m_tx_rr_ser = Mwa.m_StationA.m_tx_rr_ser;

                    FreqA.m_rx_rra_id = Mwa.m_StationB.m_tx_rra_id;
                    FreqA.m_rx_rrb_id = Mwa.m_StationB.m_tx_rrb_id;
                    FreqA.m_rx_rrs_id = Mwa.m_StationB.m_tx_rrs_id;
                    FreqA.m_rx_rr_diag = Mwa.m_StationB.m_tx_rr_diag;
                    FreqA.m_rx_rr_exc = Mwa.m_StationB.m_tx_rr_exc;
                    FreqA.m_rx_rr_ser = Mwa.m_StationB.m_tx_rr_ser;

                    FreqB.m_tx_freq = Mwa.m_StationB.m_tx_freq;
                    FreqB.m_rx_freq = Mwa.m_StationA.m_tx_freq;

                    FreqB.m_tx_rra_id = Mwa.m_StationB.m_tx_rra_id;
                    FreqB.m_tx_rrb_id = Mwa.m_StationB.m_tx_rrb_id;
                    FreqB.m_tx_rrs_id = Mwa.m_StationB.m_tx_rrs_id;
                    FreqB.m_tx_rr_diag = Mwa.m_StationB.m_tx_rr_diag;
                    FreqB.m_tx_rr_exc = Mwa.m_StationB.m_tx_rr_exc;
                    FreqB.m_tx_rr_ser = Mwa.m_StationB.m_tx_rr_ser;

                    FreqB.m_rx_rra_id = Mwa.m_StationA.m_tx_rra_id;
                    FreqB.m_rx_rrb_id = Mwa.m_StationA.m_tx_rrb_id;
                    FreqB.m_rx_rrs_id = Mwa.m_StationA.m_tx_rrs_id;
                    FreqB.m_rx_rr_diag = Mwa.m_StationA.m_tx_rr_diag;
                    FreqB.m_rx_rr_exc = Mwa.m_StationA.m_tx_rr_exc;
                    FreqB.m_rx_rr_ser = Mwa.m_StationA.m_tx_rr_ser;

                }                        
                else if (Mwa.m_StationA.m_tx_freq != Null.D && Mwa.m_StationB.m_tx_freq == Null.D)
                {
                    FreqA.m_tx_freq = Mwa.m_StationA.m_tx_freq;

                    FreqA.m_tx_rra_id = Mwa.m_StationA.m_tx_rra_id;
                    FreqA.m_tx_rrb_id = Mwa.m_StationA.m_tx_rrb_id;
                    FreqA.m_tx_rrs_id = Mwa.m_StationA.m_tx_rrs_id;
                    FreqA.m_tx_rr_diag = Mwa.m_StationA.m_tx_rr_diag;
                    FreqA.m_tx_rr_exc = Mwa.m_StationA.m_tx_rr_exc;
                    FreqA.m_tx_rr_ser = Mwa.m_StationA.m_tx_rr_ser;


                    FreqB.m_rx_freq = Mwa.m_StationA.m_tx_freq;

                    FreqB.m_rx_rra_id = Mwa.m_StationA.m_tx_rra_id;
                    FreqB.m_rx_rrb_id = Mwa.m_StationA.m_tx_rrb_id;
                    FreqB.m_rx_rrs_id = Mwa.m_StationA.m_tx_rrs_id;
                    FreqB.m_rx_rr_diag = Mwa.m_StationA.m_tx_rr_diag;
                    FreqB.m_rx_rr_exc = Mwa.m_StationA.m_tx_rr_exc;
                    FreqB.m_rx_rr_ser = Mwa.m_StationA.m_tx_rr_ser;
                }
                else
                {
                    FreqA.m_tx_freq = Mwa.m_StationA.m_tx_freq;
                    FreqB.m_tx_freq = Mwa.m_StationB.m_tx_freq;
                    MessageBox.Show("Fréquences non paramétrés, veuillez finir la saisie à la main");
                }

                FreqA.Save(); FreqB.Save();

                //Station A devient maitre, Station B devient esclave
                OTS_B.m_rec_id = OTS_A.m_id;
                OTS_B.Save();

                //Ajouter un REC_HISTORY qui indique le transfert
                YRecHistory recMw = new YRecHistory();
                YRecHistory recA = new YRecHistory();
                YRecHistory recB = new YRecHistory();
                recA.m_obj_tbid = OTS_A.m_id; recA.AllocID();
                recA.m_obj_tbnm = "MOB_STATION";
                recA.m_event_date = DateTime.Now;
                recA.m_user = IM.ConnectedUser();
                recA.m_fr_state = "";
                recA.m_to_state = Mwa.m_status;
                recA.m_event = $"Migration PMR de la table FH (MW_ID={Mwa.m_id}) en Autres Staitons de Terres (OTS) (MobSta_A={OTS_A.m_id}).";

                recB.m_obj_tbid = OTS_B.m_id; recB.AllocID();
                recB.m_obj_tbnm = "MOB_STATION";
                recB.m_event_date = DateTime.Now;
                recB.m_user = IM.ConnectedUser();
                recB.m_fr_state = "";
                recB.m_to_state = Mwa.m_status;
                recB.m_event = $"Migration PMR de la table FH (MW_ID={Mwa.m_id}) en Autres Staitons de Terres (OTS) (MobSta_B={OTS_B.m_id}).";

                recMw.m_obj_tbid = Mwa.m_id; recMw.AllocID();
                recMw.m_obj_tbnm = "MICROWA";
                recMw.m_event_date = DateTime.Now;
                recMw.m_user = IM.ConnectedUser();
                recMw.m_fr_state = Mwa.m_status;
                recMw.m_to_state = "S1";
                recMw.m_event = $"Migration PMR de la table FH (MW_ID={Mwa.m_id}) vers Autres Staitons de Terres (OTS)(MW_ID={Mwa.m_id}).";

                recA.Save(); recMw.Save(); recMw.Save();

                //passer l'original en S1
                Mwa.m_status = "S1"; Mwa.SaveWithComponents();

                MessageBox.Show("Migration terminée. Le Microwave original a été passé en S1.");
            }
            else
            {
                MessageBox.Show("Cette liaison n'est pas compatible avec un transofert vers OtherTerrestrial Stations.");
            }

            return true;
        }
    }
}
